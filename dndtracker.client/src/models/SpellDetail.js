export class SpellDetail {
  constructor(data) {
    this.id = data.id;
    this.index=data.index
    this.name = data.name
    this.url=data.url
    this.desc=data.desc
    this.higher_level=data.higher_level
    this.range = data.range
    this.components=data.components //enum
    this.material=data.material
    this.aoe=data.area_of_effect //object
    this.ritual = data.ritual || false
    
  }
}

