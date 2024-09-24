using JovemProgramadorMVC.Models;

namespace JovemProgramadorMVC.Data.Repositorio.Interface
{
    public interface IProfessorRepositorio
    {
        List<Professor> BuscarProfessor();
        void InserirProfessor(Professor professor);
        Professor BuscarId(int id);
        void EditarProfessor(Professor professor);

        void Excluir(Professor professor);
    }
}
