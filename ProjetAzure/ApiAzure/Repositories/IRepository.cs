using System.Linq.Expressions;

namespace ApiAzure.Repositories
{
    public interface IRepository<Entity>
    {
        // CRUD

        // Create

        bool Ajouter(Entity entity);

        // Read

        Entity ObtenirViaId(int id);

        Entity? Obtenir(Expression<Func<Entity, bool>> predicate);

        List<Entity> ObtenirTous(Expression<Func<Entity, bool>> predicate);

        List<Entity> ObtenirTous();

        // Update

        bool Modifier(Entity entity);

        // Delete

        bool Supprimer(int id);

    }
}
