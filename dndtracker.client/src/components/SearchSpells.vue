<template>
  <div class="collapse" id="searchSpells">
    <div class="card bg-transparent border-0">
      <form @submit.prevent="searchByQuery()">
        <div
          class="input-group mb-2 rounded-5 elevation-5 sticky-top p-1 searchContainer"
        >
          <input
            v-model="editable.name"
            type="text"
            class="form-control rounded-5 border-0"
            aria-label="Username"
            placeholder="Spell Name.."
            aria-describedby="basic-addon1"
          />
        </div>
        <div>
          <div class="">
            <label for="level" class="form-label">Level</label>
            <select
              v-model="editable.level"
              class="form-select form-select-sm"
              name="level"
            >
              <option selected>Select one</option>
              <option :value="i" v-for="i in 9">{{ i }}</option>
            </select>
          </div>
        </div>
        <button class="btn btn-outline-success" type="submit">search</button>
      </form>
    </div>
  </div>
</template>

<script>
import { computed } from "@vue/reactivity";
import { onMounted, ref, watchEffect } from "vue";
import { AppState } from "../AppState.js";
import { spellsService } from "../services/SpellsService.js";
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
  async searchByQuery(){
        try {
          console.log(editable.value);
            await spellsService.searchByQuery(editable.value)
          } catch (error) {
            Pop.error(error,'[searchByQuery]')
          }
      }
  }
}
}
</script>

<style lang="scss" scoped></style>
