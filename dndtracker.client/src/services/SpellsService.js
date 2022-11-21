import { AppState } from "../AppState.js";
import { Spell } from "../models/Spell.js";
import { DND } from "./AxiosService.js";

class SpellsService {
  async getSpells() {
    const res = await DND.get('api/spells')
    console.log(res.data);
    AppState.spells = res.data.results.map(s => new Spell(s))
  }
}
export const spellsService = new SpellsService();
