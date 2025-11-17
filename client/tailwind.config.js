/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ['./src/**/*.{html,ts}'],
  theme: {
    extend: {
      colors: {
        'main': '#0380a7',
				'main-dark': '#00005c',
				'main-light': '#a7cbfd',
				'support': '#ffd700',
				'dark': '#111',
				'light': '#fffdfa',
				'grey-1': '#333',
				'grey-2': '#999',
				'grey-3': '#ccc',
				'grey-4': '#eee',
      }
    },
  },
  plugins: [require('daisyui')],
  daisyui: {
    themes: ['light', 'dark', 'cupcake'],
  }
}

