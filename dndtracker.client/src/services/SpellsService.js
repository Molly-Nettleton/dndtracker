import { DND } from "./AxiosService.js";

class SpellsService {
  async getSpells(){
    const res = await DND.get('api/spells')
    console.log(res.data);
  }
}
export const spellsService = new SpellsService();
