<template>
  <div 
  :class="spell.school.color"
  class="card  spellcard px-3 elevation-5" v-if="spell">
    <h3 class="text-center text-dark bg-white mt-3 p-1 mb-0 rounded-top">{{ spell?.name }}</h3>
    <p 
    :class="spell.school.color"
    class=" text-white text-center mb-1 my-1">{{ spell?.school.name }}, Level {{ spell?.level }}</p>
    <div class="row">
      <div class="col-6 text-center ">
        <div class="bg-white">
          <h5 class="text-danger">Casting Time</h5>
          <p class="text-dark">{{ spell?.castingTime }}</p>
        </div>
      </div>
      <div class="col-6 text-center">
        <div class="bg-white">
          <h5 class="text-danger">Range</h5>
          <p class="text-dark">{{ spell?.range }}</p>
        </div>
      </div>
      <div class="col-6 text-center">
        <div class="bg-white">
          <h5 class="text-danger">Components</h5>
          <div class="d-flex justify-content-center">
            <p class="text-dark mx-2 mb-0" v-for="c in spell.components">{{ c }}</p>
          </div>
        </div>
      </div>
      <div class="col-6 text-center">
        <div class="bg-white ">
          <h5 class="text-danger ">Duration</h5>
          <p class="text-dark">{{ spell?.duration }}</p>
        </div>
      </div>
    </div>
    <div class="row ">
      <div class="col-12 ">
        <div class="scrollY">

          <p class="bg-white text-dark p-2 mb-0 " v-for="p in spell.desc">{{ p }}</p>
        </div>
        <div class="col-12 text-center text-white" >
          <p class="mb-1 mt-1 text-light" v-if="spell.higherLevel ">At Higher Levels</p>
        </div>
        <div class="col-12 bg-white text-dark mb-3 rounded-bottom">
          <div v-if="spell.higherLevel ">
            <p class="p-2" v-for="h in spell.higherLevel">{{ h}}</p>

          </div>
        
        </div>
      </div>
    </div>
  </div>
</template>


<script>
import { computed } from "@vue/reactivity";
import { AppState } from "../AppState.js";
import { SpellDetail } from "../models/SpellDetail.js";

export default {
  setup() {
    return {
      spell: computed(() => AppState.activeSpell)
    }
  }
}
</script>


<style lang="scss" scoped>

.scrollY{
  height: 300px;
  overflow-y: auto;
}
.spellcard{
width: 600px;
}

</style>