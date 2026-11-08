using System.IO.Compression;
using System.Xml;
using System.Xml.Linq;

namespace JustDoTheWork.Controller
{
    public static class DocumentoAtividade
    {
        public static bool TemConteudo(byte[]? bytes)
        {
            if (bytes is not { Length: > 0 } || bytes.Length > 10 * 1024 * 1024)
                return false;
            try
            {
                using var stream = new MemoryStream(bytes, writable: false);
                using var pacote = new ZipArchive(stream, ZipArchiveMode.Read);
                if (pacote.Entries.Count > 1000 || pacote.Entries.Sum(entrada => entrada.Length) > 40 * 1024 * 1024 ||
                    pacote.Entries.Any(entrada => entrada.FullName.EndsWith(".xml", StringComparison.OrdinalIgnoreCase) && entrada.Length > 8 * 1024 * 1024))
                    return false;
                var corpo = pacote.GetEntry("word/document.xml");
                if (corpo == null || pacote.GetEntry("[Content_Types].xml") == null)
                    return false;
                using var conteudo = corpo.Open();
                using var leitor = XmlReader.Create(conteudo, new XmlReaderSettings { DtdProcessing = DtdProcessing.Prohibit, XmlResolver = null, MaxCharactersInDocument = 8 * 1024 * 1024 });
                var documento = XDocument.Load(leitor);
                XNamespace word = "http://schemas.openxmlformats.org/wordprocessingml/2006/main";
                var body = documento.Root?.Element(word + "body");
                return body != null && (body.Descendants(word + "t").Any(texto => texto.Value.Any(letra => !char.IsWhiteSpace(letra) && letra is not ('\u200B' or '\uFEFF'))) ||
                    body.Descendants(word + "drawing").Any() || body.Descendants(word + "pict").Any());
            }
            catch (Exception erro) when (erro is InvalidDataException or IOException or XmlException)
            {
                return false;
            }
        }
    }
}
