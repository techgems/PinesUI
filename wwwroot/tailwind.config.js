// tailwind.config.js
module.exports = {
    //purge: [
    //  './Views/**/*.cshtml',
    //],
    darkMode: false, // or 'media' or 'class'
    theme: {
        extend: {
            // Add custom keyframes
            keyframes: {
                marquee: {
                    '0%': {
                        transform: 'translateX(0)'
                    },
                    '100%': {
                        transform: 'translateX(-100%)'
                    },
                },
            },
            // Add custom animations
            animation: {
                'marquee': 'marquee 20s linear infinite',
            },
        },
    },
    variants: {
        extend: {},
    },
    plugins: [],
};