import { defineConfig } from "vite";
import tailwindcss from "@tailwindcss/vite";
export default defineConfig({
  root: "Assets",
  plugins: [tailwindcss()],
  build: {
    emptyOutDir: true,
    manifest: true,
    outDir: "wwwroot/dist",
    rollupOptions: {
      input: "Assets/app.js",
      output: {
        entryFileNames: "[name].js",
        chunkFileNames: "[name].js",
        assetFileNames: "[name].[ext]",
      },
    },
  },
});
