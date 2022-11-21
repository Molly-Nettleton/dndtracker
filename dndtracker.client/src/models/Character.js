export class Character {
  constructor(data) {
    this.id = data.id;
    this.name = data.name;
    this.level = data.level;
    this.img = data.img;
    this.classes = data.classes;
    this.race = data.race;
    this.subclasses = data.subclasses;
    this.abilityScores=data.abilityScores
    this.background=data.background

  }
}
//be able to add higher level spells to be added once you reach that level
//add spell to queue for when you hit that specified level you adds to your spellbook
