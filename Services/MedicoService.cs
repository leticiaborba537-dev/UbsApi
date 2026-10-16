using System.Reflection.Metadata.Ecma335;
using UbsApi.Models;

namespace UbsApi.Services
{
    public class MedicoService
    {

        MedicoModel Medico1 = new()
        {
            Crm = "1",
            Nome = "Dra. Ana",
            Especialidade = "Clinica Geral"
        };

        MedicoModel Medico2 = new()
        {
            Crm = "2",
            Nome = "Dr. João",
            Especialidade = "Cardiologista"
        };
        private static List<MedicoModel> _ListaMedicos = new List<MedicoModel>
        {
            new MedicoModel {Crm = "2001PE",
            Nome = "Dra. Ana",
            Telefone = "81977742345",
            Especialidade = "Clinica Geral"},
            new MedicoModel {Crm = "2304PE",
            Nome = "Dr. João",
            Especialidade = "Cardiologista" }
        };

        // Validação se o CRM do médico existe

        public bool ValidarMedico(string crm)
        {
            foreach (MedicoModel medico in _ListaMedicos)
            {
                if (medico.Crm == crm)
                {
                    return true;
                }
            }
            return false;
        }

        // Cadastrar Médico
        public bool CadastrarMedico (MedicoModel novoMedico)
        {
            if (ValidarMedico(novoMedico.Crm))
            {
                return false;
            }
            _ListaMedicos.Add(novoMedico);
            return true;
        }
        
        // Editar Médico

        // Excluir Médico

        // Listar Médicos

        public List<MedicoModel> ListarMedicos()
        {
            return _ListaMedicos;
        }

        // Buscar Médico por crm

        public MedicoModel BuscarMedico(string crmBuscar)
        {
            MedicoModel medicoNaoEncontrado = new MedicoModel();

            foreach (MedicoModel medico in _ListaMedicos)
            {
                if (medico.Crm == crmBuscar)
                {
                    return medico;
                }
            }
            return medicoNaoEncontrado;
        }
    }
}
