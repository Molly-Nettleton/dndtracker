<template>
  <section class="container">
    <div class="d-flex justify-content-center p-3">

     <CharacterCard/>

    </div>
  </section>

</template>

<script>
import { onMounted } from "vue";
import CharacterCard from "../components/CharacterCard.vue";
import { spellsService } from "../services/SpellsService.js";

export default {
    setup() {
        onMounted(() => {
            // getSpells()
        });
        // async function getSpells() {
        //   try {
        //     await spellsService.getSpells();
        //   } catch (error) {
        //     Pop.error(error, "[getSpells]");
        //   }
        // }
        return {};
    },
    components: { CharacterCard }
};
</script>

<style scoped lang="scss">
.charcard {
  height: 250px;
  width: 250px;
}
</style>
