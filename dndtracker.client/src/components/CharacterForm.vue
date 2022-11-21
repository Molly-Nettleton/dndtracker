<template>
<div class="modal-body">
  <form @submit.prevent="createCharacter()">
<div class="form-floating mb-3">
  <input type="text" class="form-control" id="floatingName" placeholder="name">
  <label for="floatingName">name</label>
</div>
<div class="form-floating">
  <input type="num" class="form-control" id="floatingLevel" placeholder="Level">
  <label for="floatingLevel">Level</label>
</div>
    
    <button class="btn btn-outline-success" type="submit"></button>
  </form>
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
