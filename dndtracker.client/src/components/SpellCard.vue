<template>
  <section class="container">
    <div class="row">
      <div class="col-md-3 bg-danger">
        <h3 class="text-center text-dark bg-white mt-3 p-1 mb-0 rounded-top">ThunderClap</h3>
        <p class="bg-danger text-white text-center mb-0">Evocation cantrip</p>
        <div class="row">
          <div class="col-6 text-center ">
            <div class="bg-white">
              <h5 class="text-danger">Casting Time</h5>
              <p class="text-dark">1 action</p>
            </div>
          </div>
          <div class="col-6 text-center">
            <div class="bg-white">
              <h5 class="text-danger">Range</h5>
              <p class="text-dark">Self (5 foot radius)</p>
            </div>
          </div>
          <div class="col-6 text-center">
            <div class="bg-white">
              <h5 class="text-danger">Components</h5>
              <p class="text-dark">S</p>
            </div>
          </div>
          <div class="col-6 text-center">
            <div class="bg-white">
              <h5 class="text-danger">Duration</h5>
              <p class="text-dark">Instantaneous</p>
            </div>
          </div>
        </div>
        <div class="row">
          <div class="col-12">
            <p class="bg-white text-dark p-2 mb-0">You create a burst of thunderous sound that can be heard up to 100 feet
              away. Each creature within
              range, other than
              you, must succeed on a Constitution saving throw or take 1d6 thunder damage.</p>
            <div class="col-12 text-center text-white">
              <p class="mb-0">At Higher Levels</p>
            </div>
            <div class="col-12 bg-white text-dark mb-3 rounded-bottom">
              <p class="p-2">The spell's damage increases by 1d6 when
                you reach 5th level (2d6), 11th level (3d6), and 17th level (4d6)</p>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
</template>


<script>
export default {
  setup(){
    return {}
  }
}
</script>


<style lang="scss" scoped>

</style>