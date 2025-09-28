/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ['./src/**/*.{html,ts}'],
  theme: {
    extend: {
      colors: {
        'main': '#ff4500',
        'support': '#008080',
        'dark': '#111',
        'light': '#fffcfa',
        'grey-dark': '#333',
        'grey-medium': '#777',
        'grey-light': '#ccc',
        'grey-light-extra': '#eee',
      }
    },
  },
  plugins: [require('daisyui')],
  daisyui: {
    themes: ['light', 'dark', 'cupcake'],
  }
}

