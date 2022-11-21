<template>
  <!-- <div class="about" v-for="s in spells" :key="s.id">
    <SpellCard :spell="s"/>
  </div> -->
</template>

<script>
import { computed } from "@vue/reactivity";
import { onMounted } from "vue";
import { AppState } from "../AppState.js";
import SpellCard from "../components/ActiveSpellCard.vue";
import { spellsService } from "../services/SpellsService.js";
import Pop from "../utils/Pop.js";

export default {
  setup() {
    onMounted(() => {
      getSpells()
    });
    async function getSpells() {
      try {
          await spellsService.getSpells()
        } catch (error) {
          console.error('[getSpells]',error)
          Pop.error(error)
        }
    }
    return {
          // spells: computed(() => AppState.spells),
        };
    },
    components: { SpellCard }
}
</script>

