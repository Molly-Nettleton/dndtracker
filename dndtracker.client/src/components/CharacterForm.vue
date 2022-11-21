<template>
  <div class="modal-body">
    <form @submit.prevent="createCharacter()">
      <div class="form-floating mb-2">
        <input
          type="text"
          class="form-control"
          id="floatingName"
          placeholder="name"
        />
        <label for="floatingName">name</label>
      </div>
      <div class="form-floating mb-2">
        <input
          type="number"
          class="form-control"
          id="floatingLevel"
          placeholder="Level"
        />
        <label for="floatingLevel">Level</label>
      </div>
      <div class="form-floating mb-2">
        <input
          type="number"
          class="form-control"
          id="floatingImg"
          placeholder="Image"
        />
        <label for="floatingImg">Image</label>
      </div>
      <div class="d-flex justify-content-evenly">
<div class="mb-3">
  <label for="" class="form-label">Class</label>
  <select class="form-select form-select-lg" name="" id="">
    <option selected>Select </option>
    <option value="" v-for="c in choices" >{{c}}</option>

  </select>
</div>
<div class="mb-3">
  <label for="" class="form-label">Class</label>
  <select class="form-select form-select-lg" name="" id="">
    <option selected>Select one</option>
    <option value="" v-for="c in choices" >{{c}}</option>

  </select>
</div>
      </div>

      <button class="btn btn-outline-success" type="submit"></button>
    </form>
  </div>
</template>

<script>
import { computed } from "@vue/reactivity";
import { onMounted, ref, watchEffect } from "vue";
import { AppState } from "../AppState.js";
import { logger } from "../utils/Logger.js";
import Pop from "../utils/Pop.js";

export default {
  props: {},
  setup(props) {
    const editable = ref({});

    onMounted(() => {});
    watchEffect(() => {});

    return {
      editable,
      choices : computed(() => AppState.classChoices),
    };
  },
};
</script>

<style lang="scss" scoped></style>
