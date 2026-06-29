import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'
import { VitePWA } from 'vite-plugin-pwa'

export default defineConfig({
  plugins: [
    react(),
    VitePWA({
      registerType: 'autoUpdate',
      manifest: {
        name: 'Tarefas do Nosso Dia a Dia',
        short_name: 'Tarefas',
        description: 'Sua rotina mais vibrante e organizada.',
        theme_color: '#1A0B2E', /* O nosso Roxo Profundo no topo do celular */
        background_color: '#1A0B2E',
        display: 'standalone', /* Esconde a barra do navegador (www) */
        icons: [
          {
            src: '/icon-192.png',
            sizes: '192x192',
            type: 'image/png'
          },
          {
            src: '/icon-512.png',
            sizes: '512x512',
            type: 'image/png'
          }
        ]
      }
    })
  ]
})