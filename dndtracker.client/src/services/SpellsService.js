import { AppState } from "../AppState.js";
import { Spell } from "../models/Spell.js";
import { SpellDetail } from "../models/SpellDetail.js";
import { api, DND } from "./AxiosService.js";

class SpellsService {
  async getSpells() {
    const res = await DND.get('api/spells')
    console.log(res.data);
    AppState.spells = res.data.results.map(s => new Spell(s))
  }

  async setActiveSpell(spell) {
    console.log(spell);
    const res = await DND.get(`api/spells/${spell}`)
    console.log(res.data);
    // AppState.activeSpell = new SpellDetail(res.data)
    console.log(AppState.activeSpell)
  }
}
export const spellsService = new SpellsService();
