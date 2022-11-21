namespace dndtracker.Repositories;
public class CharactersRepository : BaseRepository
{
  public CharactersRepository(IDbConnection db) : base(db)
  {
  }

  internal Character CreateCharacter(Character characterData)
  {
    var sql = @"
             INSERT INTO
             characters (
              name,
              level,
              hp,
              img,
              mainClass,
              secondClass,
              subclasses,
              race,
              abilityScores,
              background,
              creatorId
             )
             VALUES (
              @Name,
              @Level,
              @Hp,
              @Img,
              @MainClass,
              @SecondClass,
              @Race,
              @AbilityScores,
              @Background,
              @CreatorId
             );
             SELECT LAST_INSERT_ID()
                 ; ";

    characterData.Id = _db.ExecuteScalar<int>(sql, characterData);

    return characterData;
  }
}