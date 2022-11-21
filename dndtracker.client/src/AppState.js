import { reactive } from "vue";

// NOTE AppState is a reactive object to contain app level data
export const AppState = reactive({
  user: {},
  /** @type {import('./models/Account.js').Account} */
  account: {},

  /** @type {import('./models/Spell.js').Spell[]} */
  spells: [],

  /** @type {import('./models/SpellDetail.js').SpellDetail | null} */
  activeSpell: null,

  /** @type {import('./models/Character.js').Character[]} */
  characters: [],


  classChoices:[
    'barbarian','bard','cleric','druid','fighter','monk','paladin','ranger','rogue','sorcerer','warlock','wizard'
  ]
  
});
