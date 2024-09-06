using JovemProgramadorMVC.Models;

namespace JovemProgramadorMVC.Data.Repositorio.Interface
{
    public interface IAlunoRepositorio
    { 
        List<Aluno> BuscarAlunos();
        void InserirAluno(Aluno aluno);
        Aluno BuscarId(int id);
        void EditarAluno(Aluno aluno);

        void Excluir(Aluno aluno);
    }
}
