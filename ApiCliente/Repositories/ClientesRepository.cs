using testeentity.Models;
using testeentity.Models.Entities.Clientes;

namespace testeentity.Repositories
{
    public interface IClientesRepository
    {
        public bool Create(PostClientes cliente);
        public Clientes Read(int id);
        public bool Update(PutClientes cliente);
        public bool Delete(int id);
        public List<Clientes> ListAll();
    }
    public class ClientesRepository : IClientesRepository
    {

        private readonly _DbContext db;

        public ClientesRepository(_DbContext _db)
        {
            this.db = _db;
        }

        public bool Create(PostClientes cliente)
        {
            try
            {
                List<Clientes> clientes = db.clientes.Where(p => p.CNPJ == cliente.CNPJ).ToList();
                if (clientes.Count > 0)
                {
                    return false;
                }

                var cliente_db = new Clientes()
                {
                    Nome = cliente.Nome,
                    CNPJ = cliente.CNPJ,
                    DtNascimento = cliente.DtNascimento,
                    DtCadastro = DateTime.Now,
                    Telefone = cliente.Telefone,
                    Endereco = cliente.Endereco
                };
                db.clientes.Add(cliente_db);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var cliente_db = db.clientes.Find(id);
                db.clientes.Remove(cliente_db);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Clientes> ListAll()
        {
            try
            {
                var cliente_db = db.clientes.ToList();
                return cliente_db;
            }
            catch
            {
                return new List<Clientes>();
            }
        }

        public Clientes Read(int id)
        {

            try
            {
                var cliente_db = db.clientes.Find(id);
                return cliente_db;
            }
            catch
            {
                return new Clientes();
            }
        }

        public bool Update(PutClientes cliente)
        {
            try
            {
                var cliente_db = db.clientes.Find(cliente.Id);
                cliente_db.Nome = cliente.Nome;
                cliente_db.DtNascimento = cliente.DtNascimento;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
