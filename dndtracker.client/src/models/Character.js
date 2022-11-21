export class Character {
  constructor(data) {
    this.id = data.id;
    this.name = data.name;
    this.level = data.level;
    this.classes = data.classes;
    this.subclasses = data.subclasses;
    this.spells = data.spells;
  }
}
//be able to add higher level spells to be added once you reach that level
//add spell to queue for when you hit that specified level you adds to your spellbook
