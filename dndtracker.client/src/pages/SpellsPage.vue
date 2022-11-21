<template>
  <div class="spells">
    <main class="d-flex">
      <section class="start-bar bg-dark text-light overflow-auto">
        <h4 class="p-3">Spells</h4>
        <div id="dnd-spells" v-for="s in spells">
          {{ s.name }}
        </div>
      </section>
      <section class="main-content p-3">
        <div id="active-spell">
        </div>
      </section>
      <section class="end-bar bg-dark text-light flex-grow-1">
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
      spells: computed(() => AppState.spells)
    };
  },
};
</script>



<style lang="scss" scoped>
.start-bar {
  height: 649px
}
</style>