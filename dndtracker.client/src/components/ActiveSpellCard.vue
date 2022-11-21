<template>
  <div class="card bg-danger spellcard" v-if="spell">
    <h3 class="text-center text-dark bg-white mt-3 p-1 mb-0 rounded-top">{{ spell?.name }}</h3>
    <p class="bg-danger text-white text-center mb-0">{{ spell?.school.name }}, Level {{ spell?.level }}</p>
    <div class="row">
      <div class="col-6 text-center ">
        <div class="bg-white">
          <h5 class="text-danger">Casting Time</h5>
          <p class="text-dark">{{ spell?.casting_time }}</p>
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
        <div class="bg-white">
          <h5 class="text-danger">Duration</h5>
          <p class="text-dark">{{ spell?.duration }}</p>
        </div>
      </div>
    </div>
    <div class="row">
      <div class="col-12">
        <p class="bg-white text-dark p-2 mb-0" v-for="p in spell.desc">{{ p }}</p>
        <div class="col-12 text-center text-white">
          <p class="mb-0">At Higher Levels</p>
        </div>
        <div class="col-12 bg-white text-dark mb-3 rounded-bottom">
          <p class="p-2">{{ spell?.higher_level }}</p>
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
.spellcard{
width: 600px;
}

</style>