import { AppState } from "../AppState.js";
import { Spell } from "../models/Spell.js";
import { api, DND } from "./AxiosService.js";

class SpellsService {
  async getSpells() {
    const res = await DND.get('api/spells')
    console.log(res.data);
    AppState.spells = res.data.results.map(s => new Spell(s))
  }

  async setActiveSpell(spell) {
    await api.get(`api/spells/${spell.id}`)
    AppState.activeSpell = spell
    console.log(AppState.activeSpell)
  }
}
export const spellsService = new SpellsService();
