<template>


<section class="container">
  <div class="pt-md-5 pt-3 pb-4 ">
    <div class="masonrycol">
      <div class="d-flex align-items-center">
        <div class="card bg-dark text-white border border-0 elevation-5 hoverable my-2 hover">
          <img src="src\assets\img\class-icons\Class Icon - Wizard.svg" class="card-img" alt="...">
          <div class="card-img-overlay d-flex align-items-end justify-content-between">
            <div class="card-title fontbg fs-3 fw-bold text-lowercase">
              <span class="title">character name</span>
            </div>
            <img src="src\assets\img\class-icons\Class Icon - Sorcerer.svg" height="40" width="40"
              class="rounded-circle elevation-2 userpic border border-2 border-solid border-white" alt="">
          </div>
        </div>
      </div>
    </div>
  </div>
</section>

</template>

<script>
import { onMounted } from "vue";
import { spellsService } from "../services/SpellsService.js";

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
    return {};
  },
};
</script>

<style scoped lang="scss">
.home {
  display: grid;
  height: 80vh;
  place-content: center;
  text-align: center;
  user-select: none;

  .home-card {
    width: 50vw;

    > img {
      height: 200px;
      max-width: 200px;
      width: 100%;
      object-fit: contain;
      object-position: center;
    }
  }
}
</style>
