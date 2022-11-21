<template>
  <div class="container-fluid">
    <main class="row">
      <section class="col-md-2 bg-dark text-light">
        <div class="d-flex justify-content-center">
          <h4 class="p-3">Spells</h4>

          <button
            class="btn border-0"
            type="button"
            data-bs-toggle="collapse"
            data-bs-target="#searchSpells"
            aria-expanded="false"
            aria-controls="collapseExample"
          >
            <i class="mdi mdi-magnify fs-3 text-light"></i>
          </button>
        </div>
        <!-- SEARCH -->
       <SearchSpells/>
        <!-- SEARCH -->

        <div class="start-bar">
          <div
            @click="getSpellDetails(s)"
            id="dnd-spells"
            v-for="s in spells"
            class="hover selectable p-1 rounded"
          >
            <span class=" ">{{ s?.name }}</span>
          </div>
        </div>
      </section>

      <section
        class="col-md-8 main-content p-3 d-flex align-items-center justify-content-center"
      >
        <div id="active-spell">
          <ActiveSpellCard />
        </div>
      </section>
      <section
        class="col-md-2 end-bar bg-dark text-light flex-grow-1 spellbook"
      >
        <h4 class="p-3">Your Spells 📖 <span id="spell-count"></span></h4>
        <div id="spell-slots"></div>
      </section>
    </main>
  </div>
</template>

<script>
import { computed, ref } from "@vue/reactivity";
import { onMounted } from "vue";
import { AppState } from "../AppState.js";
import SearchSpells from "../components/SearchSpells.vue";
import { Spell } from "../models/Spell.js";
import { spellsService } from "../services/SpellsService.js";
import Pop from "../utils/Pop.js";

export default {
  setup() {
    onMounted(() => {
      getSpells();
    });
    const editable = ref({});
    async function getSpells() {
      try {
        await spellsService.getSpells();
      } catch (error) {
        Pop.error(error, "[getSpells]");
      }
    }
    return {
      editable,
      spells: computed(() => AppState.spells),
      async getSpellDetails(s) {
        try {
          // let name = props.spell.name
          await spellsService.setActiveSpell(s.index);
        } catch (error) {
          console.error("[]", error);
          Pop.error(error);
        }
      },
    };
  },
  components: { SearchSpells },
};
</script>

<style lang="scss" scoped>
.start-bar {
  height: 83.2vh;
  overflow-y: auto;
}

.spellbook {
  width: 100px;
}
</style>
