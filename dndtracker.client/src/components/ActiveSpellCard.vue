<template>
  <div class="col-md-3 bg-danger">
    <h3 class="text-center text-dark bg-white mt-3 p-1 mb-0 rounded-top">{{ spell?.name }}</h3>
    <p class="bg-danger text-white text-center mb-0">{{ spell?.school }} {{ spell?.level }}</p>
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
          <p class="text-dark">{{ spell?.components }}</p>
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
        <p class="bg-white text-dark p-2 mb-0">{{ spell?.desc }}</p>
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
import { SpellDetail } from "../models/SpellDetail.js";

export default {
  props: {
    spell: {
      type: SpellDetail,
      required: true
    }
  },
  setup() {
    return {}
  }
}
</script>


<style lang="scss" scoped>

</style>