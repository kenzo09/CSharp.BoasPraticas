namespace APP.AulaAtributo
{
    internal class AlunoDebugProxy
    {
        private readonly Aluno _aluno;
        public AlunoDebugProxy(Aluno aluno)
        {
            _aluno = aluno;
        }

        public string Aluno => $"Aluno: {_aluno.Nome.ToUpperInvariant()}, Matrícula: {_aluno.Matricula}";
        public string IsReprovacao => $"Reprovado em alguma disciplina: {_aluno.Curso.Disciplinas.Exists(a => a.Nota < 7)}";
    }
}