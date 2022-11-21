import { AppState } from "../AppState.js";
import { Character } from "../models/Character.js";
import { api } from "./AxiosService.js";

class CharactersService {
  async addCharacter(data) {
    const res = api.post("api/characters", data);

    AppState.characters.push(new Character(res.data));
  }

  
}
export const charactersService = new CharactersService();
