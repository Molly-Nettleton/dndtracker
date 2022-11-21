<template>
  <div class="modal-body">

    <div class="row">
      <div class="col-md-6 d-flex justify-content-center  " >
        <div class="card  ">
          <img :src="editable.img" alt="" class="rounded-top elevation-3 img-fluid ">
<div class="card-body bg-dark rounded-bottom">
  <p class="fontbg fs-3 fw-bold text-lowercase">
    {{editable.name}}


  </p>
</div>
        </div>
      </div>
      <div class="col-md-6">
  <form @submit.prevent="createCharacter()">
      <div class="form-floating mb-2">
        <input
          type="text"
          class="form-control"
          id="floatingName"
          placeholder="name"
          v-model="editable.name"
        />
        <label for="floatingName">name</label>
      </div>
      <div class="form-floating mb-2">
        <input
          type="number"
          class="form-control"
          id="floatingLevel"
          placeholder="Level"
          v-model="editable.level"
        />
        <label for="floatingLevel">Level</label>
      </div>
      <div class="form-floating mb-2">
        <input
          type="url"
          class="form-control"
          id="floatingImg"
          placeholder="Image"
          v-model="editable.img"
        />
        <label for="floatingImg">Image</label>
      </div>

      <div class="form-floating mb-2">
        <input
          type="text"
          class="form-control"
          id="floatingRace"
          placeholder="Race"
          v-model="editable.race"
        />
        <label for="floatingRace">Race</label>
      </div>

      <div class="d-flex justify-content-evenly">
        <div class="mb-3">
          <label for="" class="form-label">Class</label>
          <select
            v-model="editable.classes"
            class="form-select form-select-lg"
            name=""
            id=""
          >
            <option selected>Select</option>
            <option :value="c" v-for="c in choices">{{ c }}</option>
          </select>
        </div>
        <div class="mb-3">
          <label for="" class="form-label">Class</label>
          <select
            v-model="editable.secondClass"
            class="form-select form-select-lg"
            name=""
            id=""
          >
            <option selected>Select one</option>
            <option :value="c" v-for="c in choices">{{ c }}</option>
          </select>
        </div>
      </div>

      <div
        class="d-flex flex-column align-content-center justify-content-center"
      >
        <input type="number" name="" id="" />
      </div>

      <div>
        <div class="mb-3">
          <label for="" class="form-label">Background</label>
          <textarea
            v-model="editable.background"
            class="form-control"
            name=""
            id=""
            rows="5"
          ></textarea>
        </div>
      </div>

      <button class="btn btn-outline-success" type="submit">
        Create Character
      </button>
    </form>
      </div>
    </div>
  
  </div>
</template>

<script>
import { computed } from "@vue/reactivity";
import { onMounted, ref, watchEffect } from "vue";
import { AppState } from "../AppState.js";
import { charactersService } from "../services/CharactersService.js";
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
      choices: computed(() => AppState.classChoices),
      async createCharacter() {
        try {
          editable.value.classes = (editable.value.classes +','+
            editable.value.secondClass).toString()
            
          
          delete editable.value.secondClass;
          console.log(editable.value);
          // await charactersService.createCharacter(editable.value);
        } catch (error) {
          Pop.error(error, "[createCharacter]");
        }
      },
    };
  },
};
</script>

<style lang="scss" scoped>

.charcard {
  height: 250px;
  width: 250px;
}
</style>
