import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'
// import { VitePWA } from 'vite-plugin-pwa' // PWA desativado temporariamente para o deploy

export default defineConfig({
  plugins: [
    react(),
    // VitePWA({
    //   registerType: 'autoUpdate',
    //   manifest: {
    //     name: 'Tarefas do Nosso Dia a Dia',
    //     short_name: 'Tarefas',
    //     description: 'Sua rotina mais vibrante e organizada.',
    //     theme_color: '#1A0B2E',
    //     background_color: '#1A0B2E',
    //     display: 'standalone',
    //     icons: [
    //       {
    //         src: '/icon-192.png',
    //         sizes: '192x192',
    //         type: 'image/png'
    //       },
    //       {
    //         src: '/icon-512.png',
    //         sizes: '512x512',
    //         type: 'image/png'
    //       }
    //     ]
    //   }
    // })
  ]
})