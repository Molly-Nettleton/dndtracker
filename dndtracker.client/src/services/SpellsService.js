import { AppState } from "../AppState.js";
import { Spell } from "../models/Spell.js";
import { SpellDetail } from "../models/SpellDetail.js";
import { api, DND } from "./AxiosService.js";

class SpellsService {
  async getSpells() {
    const res = await DND.get('api/spells',{
      params:{
        
      }
    })
    console.log(res.data);
    AppState.spells = res.data.results.map(s => new Spell(s))
  }

  async setActiveSpell(spell) {
    console.log(spell);
    const res = await DND.get(`api/spells/${spell}`)
    console.log(res.data);
    AppState.activeSpell = new SpellDetail(res.data)
  }
  async searchByQuery(term){
const res = await DND.get(`api/spells/`,{
  params:{
    level: term.level,
    
  }
})
console.log(res.data);
AppState.spells = res.data.results.map(s => new Spell(s))
  }
}
export const spellsService = new SpellsService();
