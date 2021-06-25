module.exports = {
  purge: {
        enabled: true,
        content: [
            './**/*.html',
            './**/*.razor'
        ],
    },
  darkMode: false, // or 'media' or 'class'
  theme: {
	  colors: {
      primary: 'var(--color-primary)',
      secondary: 'var(--color-secondary)',
    },
    extend: {},
  },
  variants: {
    extend: {},
  },
  plugins: [],
}
