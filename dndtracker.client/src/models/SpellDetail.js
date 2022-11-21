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

    if (data.school.index == "abjuration") {
      data.school.color = "bg-abjuration";
    }
    if (data.school.index == "conjuration") {
      data.school.color = "bg-conjuration";
    }
    if (data.school.index == "divination") {
      data.school.color = "bg-divination";
    }
    if (data.school.index == "conjuration") {
      data.school.color = "bg-conjuration";
    }
    if (data.school.index == "enchantment") {
      data.school.color = "bg-enchantment";
    }
    if (data.school.index == "evocation") {
      data.school.color = "bg-evocation";
    }
    if (data.school.index == "illusion") {
      data.school.color = "bg-illusion";
    }
    if (data.school.index == "necromancy") {
      data.school.color = "bg-necromancy";
    }
    if (data.school.index == "transmutation") {
      data.school.color = "bg-transmutation";
    }

    this.classes = data.classes;
    this.subclasses = data.subclasses;
  }
}
