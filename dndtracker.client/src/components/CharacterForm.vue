<template>
<div class="modal-body">
  <form @submit.prevent="createCharacter()">
<div class="form-floating mb-3">
  <input type="name" class="form-control" id="floatingInput" placeholder="name@example.com">
  <label for="floatingInput">name</label>
</div>
<div class="form-floating">
  <input type="password" class="form-control" id="floatingPassword" placeholder="Password">
  <label for="floatingPassword">Password</label>
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
