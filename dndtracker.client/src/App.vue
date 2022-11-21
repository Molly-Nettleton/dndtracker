<template>
  <header>
    <Navbar />
  </header>
  <main>
    <router-view />
  </main>

  <ModalComponent id="characterForm">
    <CharacterForm />
  </ModalComponent>
  <footer class="bg-dark text-light">Made with 💖 by CodeWorks</footer>
</template>

<script>
import { computed } from "vue";
import { AppState } from "./AppState";
import CharacterForm from "./components/CharacterForm.vue";
import ModalComponent from "./components/ModalComponent.vue";
import Navbar from "./components/Navbar.vue";

export default {
  setup() {
    return {
      appState: computed(() => AppState),
    };
  },
  components: { Navbar, ModalComponent, CharacterForm },
};
</script>
<style lang="scss">
@import "./assets/scss/main.scss";

:root {
  --main-height: calc(100vh - 32px - 64px);
}

footer {
  display: grid;
  place-content: center;
  height: 32px;
}
</style>
