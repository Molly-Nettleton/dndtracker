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
              classes,
              secondClasses,
              subClass,
              race,
              background,
              creatorId
             )
             VALUES (
              @Name,
              @Level,
              @Hp,
              @Img,
              @Classes,
              @SecondClasses,
              @SubClass,
              @Race,
              @Background,
              @CreatorId
             );
             SELECT LAST_INSERT_ID()
                 ; ";

    characterData.Id = _db.ExecuteScalar<int>(sql, characterData);

    return characterData;
  }
}