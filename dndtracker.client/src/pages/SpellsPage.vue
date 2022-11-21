<template>
  <div class="spells">
    <main class="d-flex">
      <section class="start-bar bg-dark text-light">
        <h4 class="p-3">Spells</h4>
        <div id="dnd-spells">
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
export default {
  setup() {
    return {}
  }
}
</script>


<style lang="scss" scoped>

</style>