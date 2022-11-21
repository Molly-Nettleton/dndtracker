<template>
  <div class="container-fluid">
    <main class="row">
      <section class=" col-md-2 start-bar bg-dark text-light overflow-auto">
        <h4 class="p-3">Spells</h4>
        <div id="dnd-spells" v-for="s in spells">
          <span @click="getSpellDetails(s)">{{ s.name }}</span>
        </div>
      </section>
      
      <section class=" col-md-6 main-content p-3 d-flex align-items-center justify-content-center">
        <div id="active-spell">
          <ActiveSpellCard />
        </div>
      </section>
      <section class="col-md-2 end-bar bg-dark text-light flex-grow-1 spellbook">
        <h4 class="p-3 ">Your Spells 📖 <span id="spell-count"></span></h4>
        <div id="spell-slots">

        </div>
      </section>
    </main>
  </div>
</template>


<script>
import { computed } from "@vue/reactivity";
import { onMounted } from "vue";
import { AppState } from "../AppState.js";
import { Spell } from "../models/Spell.js";
import { spellsService } from "../services/SpellsService.js";
import Pop from "../utils/Pop.js";

export default {
  setup() {
    onMounted(() => {
      getSpells()
    });
    async function getSpells() {
      try {
        await spellsService.getSpells();
      } catch (error) {
        Pop.error(error, "[getSpells]");
      }
    }
    return {
      spells: computed(() => AppState.spells),

      async getSpellDetails(s) {
        try {
          // let name = props.spell.name
          await spellsService.setActiveSpell(s.index)
        } catch (error) {
          console.error('[]', error)
          Pop.error(error)
        }
      }
    };
  },
};
</script>



<style lang="scss" scoped>
.start-bar {
  height: 649px
}

.spellbook {
  width: 100px;
}
</style>