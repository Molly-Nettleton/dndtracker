<template>
    <div class="card charcard bg-dark text-white border border-0 elevation-5 hoverable hover ms-4">
        <img src="src\assets\img\character-images\ren.png" class="card-img rounded-0 rounded-top" alt="..." height="250"
          width="250">
        <div class="card-footer d-flex justify-content-between bg-dark">
          <div class="card-title fontbg fs-3 fw-bold text-lowercase">
            <span class="title">Ren</span>
          </div>
          <div class="d-flex align-items-center">
            <img src="src\assets\img\class-icons\Class Icon - Paladin.svg" height="40" width="40"
              class="rounded-circle elevation-2 border border-2 bg-white ms-1" alt="">
            <img src="src\assets\img\class-icons\Class Icon - Warlock.svg" height="40" width="40"
              class="rounded-circle elevation-2 border border-2 bg-white ms-1" alt="">
          </div>
        </div>
      </div>

        <div class="card charcard bg-dark text-white border border-0 elevation-5 hoverable hover ms-4">
        <img src="src\assets\img\character-images\28bPgSa.png" class="card-img rounded-0 rounded-top" alt="..."
          height="250" width="250">
        <div class="card-footer d-flex justify-content-between bg-dark">
          <div class="card-title fontbg fs-3 fw-bold text-lowercase">
            <span class="title">Calith</span>
          </div>
          <div class="d-flex align-items-center">
            <img src="src\assets\img\class-icons\Class Icon - Wizard.svg" height="40" width="40"
              class="rounded-circle elevation-2 border border-2 bg-white ms-1" alt="">
          </div>
        </div>
      </div>


            <div class="card charcard bg-dark text-white border border-0 elevation-5 hoverable hover ms-4">
        <img src="src\assets\img\character-images\PRLGmBW.png" class="card-img rounded-0 rounded-top" alt="..."
          height="250" width="250">
        <div class="card-footer d-flex justify-content-between bg-dark">
          <div class="card-title fontbg fs-3 fw-bold text-lowercase">
            <span class="title">Imogen</span>
          </div>
          <div class="d-flex align-items-center">
            <img src="src\assets\img\class-icons\Class Icon - Warlock.svg" height="40" width="40"
              class="rounded-circle elevation-2 border border-2 bg-white ms-1" alt="">
            <img src="src\assets\img\class-icons\Class Icon - Rogue.svg" height="40" width="40"
              class="rounded-circle elevation-2 border border-2 bg-white ms-1" alt="">
          </div>
        </div>
      </div>


</template>

<script>
import { computed } from "@vue/reactivity";
import { onMounted, ref, watchEffect } from "vue";
import { AppState } from "../AppState.js";
import { logger } from "../utils/Logger.js"
import Pop from "../utils/Pop.js";

export default {
props:{

       },
  setup(props) {
    const editable = ref({});
    
    onMounted(() => {

    });
    watchEffect(() => {});

    return {
      editable,
      }
    }
  }
</script>

<style lang="scss" scoped>
</style>
