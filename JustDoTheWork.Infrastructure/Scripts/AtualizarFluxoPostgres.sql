DO $$
BEGIN
    PERFORM pg_advisory_xact_lock(hashtext('JustDoTheWork.FluxoAtividade'));
    IF NOT EXISTS (SELECT 1 FROM information_schema.columns WHERE table_schema = 'public' AND table_name = 'atividade' AND column_name = 'etapa') THEN
        ALTER TABLE public.atividade ADD COLUMN etapa INTEGER NOT NULL DEFAULT 1;
        UPDATE public.atividade SET etapa = 4 WHERE status = 6;
        UPDATE public.atividade SET status = 2 WHERE status = 1;
    END IF;
    ALTER TABLE public.atividade ADD COLUMN IF NOT EXISTS usuarioresponsavelid INTEGER NULL;
    IF NOT EXISTS (SELECT 1 FROM pg_constraint WHERE conname = 'fk_usuarioresponsavel_atividade' AND conrelid = 'public.atividade'::regclass) THEN
        ALTER TABLE public.atividade ADD CONSTRAINT fk_usuarioresponsavel_atividade FOREIGN KEY (usuarioresponsavelid) REFERENCES public.usuario(id);
    END IF;
    CREATE INDEX IF NOT EXISTS ix_atividade_usuarioresponsavelid_status ON public.atividade(usuarioresponsavelid, status);
    ALTER TABLE public.atividade ADD COLUMN IF NOT EXISTS ultimodesenvolvedorid INTEGER NULL;
    ALTER TABLE public.atividade ADD COLUMN IF NOT EXISTS retornoexclusivo BOOLEAN NOT NULL DEFAULT FALSE;
    ALTER TABLE public.execucao ADD COLUMN IF NOT EXISTS usuarioid INTEGER NULL;
    ALTER TABLE public.execucao ADD COLUMN IF NOT EXISTS etapa INTEGER NULL;
    IF NOT EXISTS (SELECT 1 FROM pg_constraint WHERE conname = 'fk_atividade_ultimodesenvolvedor' AND conrelid = 'public.atividade'::regclass) THEN
        ALTER TABLE public.atividade ADD CONSTRAINT fk_atividade_ultimodesenvolvedor FOREIGN KEY (ultimodesenvolvedorid) REFERENCES public.usuario(id);
    END IF;
    IF NOT EXISTS (SELECT 1 FROM pg_constraint WHERE conname = 'fk_execucao_usuario' AND conrelid = 'public.execucao'::regclass) THEN
        ALTER TABLE public.execucao ADD CONSTRAINT fk_execucao_usuario FOREIGN KEY (usuarioid) REFERENCES public.usuario(id);
    END IF;
    CREATE INDEX IF NOT EXISTS ix_execucao_atividade_etapa_datafim ON public.execucao(atividadeid, etapa, datafim);
END $$;
