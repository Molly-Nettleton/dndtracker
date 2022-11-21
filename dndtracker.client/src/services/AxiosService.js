import Axios from "axios";
import { baseURL } from "../env";
export const api = Axios.create({
  baseURL,
  timeout: 8000,
});
export const DND = Axios.create({
  baseURL: "https://www.dnd5eapi.co",
  timeout: 8000,
});
