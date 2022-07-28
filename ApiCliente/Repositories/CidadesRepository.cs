using testeentity.Models;
using testeentity.Models.Entities.Cidades;

namespace testeentity.Repositories
{
    public interface ICidadesRepository
    {
        public bool Create(PostCidade cidade);
        public Cidades Read(int id);
        public bool Update(PutCidade cidade);
        public bool Delete(int id);
        public List<Cidades> ReadAll();
    }

    public class CidadesRepository : ICidadesRepository
    {
        private readonly _DbContext db;

        public CidadesRepository(_DbContext _db)
        {
            db = _db;
        }
        public bool Create(PostCidade cidade)
        {
            try
            {
                var cidade_db = new Cidades()
                {
                    Nome = cidade.Nome,
                    NomeEstado = cidade.NomeEstado
                };
                db.cidades.Add(cidade_db);
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public Cidades Read(int id)
        {
            try
            {
                var cidade_db = db.cidades.Find(id);
                return cidade_db;
            }
            catch
            {
                return new Cidades();
            }
        }

        public bool Update(PutCidade cidade)
        {
            try
            {
                var cidade_db = db.cidades.Find(cidade.Id);
                cidade_db.Nome = cidade.Nome;
                cidade_db.NomeEstado = cidade.NomeEstado;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool Delete(int id)
        {
            try
            {
                var cidade_db = db.cidades.Find(id);
                db.cidades.Remove(cidade_db);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Cidades> ReadAll()
        {
            try
            {
                var cidade_db = db.cidades.ToList();
                return cidade_db;
            }
            catch
            {
                return new List<Cidades>();
            }
        }
    }

}
