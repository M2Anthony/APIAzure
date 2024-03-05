using ApiAzure.Models;

namespace ApiAzure.Data
{
    public class FakeDragonDb
    {
        private List<Dragon> _listeDragons;
        private int _dernierId = 0;

        public FakeDragonDb()
        {
            _listeDragons = new List<Dragon>()
            {
                new Dragon {Id = ++_dernierId, Nom = "Drogon", Age = 6, Description = "Le favori des dragons"},

                new Dragon {Id = ++_dernierId, Nom = "Viserion", Age = 6, Description = "Le dragon qui porte le nom de son frère"},

                new Dragon {Id = ++_dernierId, Nom = "Rhaegal", Age = 6, Description = "Le dragon qui porte le nom de son père (enfin je crois...)"},
            };
        }

        // CRUD

        // Create

        public bool Ajouter(Dragon dragon)
        {
            dragon.Id = ++_dernierId;
            _listeDragons.Add(dragon);
            return true;
        }

        // Read

        public Dragon ObtenirViaId(int id)
        {
            return _listeDragons.FirstOrDefault(i => i.Id == id);
        }

        public List<Dragon> ObtenirTous()
        {
            return _listeDragons;
        }

        // Update

        public bool Modifier(Dragon dragon)
        {
            var dragonFromFakeDb = ObtenirViaId(dragon.Id);

            if (dragonFromFakeDb == null)
            {
                return false;
            }

            if (dragonFromFakeDb.Age != dragon.Age)
                dragonFromFakeDb.Age = dragon.Age;
            if (dragonFromFakeDb.Nom != dragon.Nom)
                dragonFromFakeDb.Nom = dragon.Nom;
            if (dragonFromFakeDb.Description != dragon.Description)
                dragonFromFakeDb.Description = dragon.Description;

            return true;
        }

        public bool Supprimer(int id)
        {
            var dragonASupprimer = ObtenirViaId(id);

            if (dragonASupprimer == null)
            {
                return false;
            }

            _listeDragons.Remove(dragonASupprimer);

            return true;
        }

    }
}
