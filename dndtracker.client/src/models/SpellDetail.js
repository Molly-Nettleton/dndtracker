export class SpellDetail {
  constructor(data) {
    this.id = data.id;
    this.index = data.index;
    this.name = data.name;
    this.url = data.url;
    this.desc = data.desc;
    this.higher_level = data.higher_level;
    this.range = data.range;
    this.components = data.components; //enum
    this.material = data.material;
    this.aoe = data.area_of_effect; //object
    this.ritual = data.ritual || false;
    this.duration = data.duration;
    this.concentration = data.concentration || false;
    this.casting_time = data.casting_time;
    this.level = data.level;
    this.attack_type = data.attack_type;
    this.damage = data.damage;
    this.school = data.school;
    this.classes = data.classes;
    this.subclasses = data.subclasses;
  }
}
