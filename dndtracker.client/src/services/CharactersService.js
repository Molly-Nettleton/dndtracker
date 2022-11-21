import { AppState } from "../AppState.js";
import { Character } from "../models/Character.js";
import { api } from "./AxiosService.js";

class CharactersService {
  async createCharacter(data) {
    const res = api.post("api/characters", data);
console.log(res.data);
    // AppState.characters.push(new Character(res.data));
  }

  async editCharacter(data){
    const res = api.put(`api/characters/${id}`,data)
  }
}
export const charactersService = new CharactersService();
