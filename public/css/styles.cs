/*
! tailwindcss v3.2.0 | MIT License | https://tailwindcss.com
*/

/*
1. Prevent padding and border from affecting element width. (https://github.com/mozdevs/cssremedy/issues/4)
2. Allow adding a border to an element by just adding a border-width. (https://github.com/tailwindcss/tailwindcss/pull/116)
*/

*,
::before,
::after {
  box-sizing: border-box;
  /* 1 */
  border-width: 0;
  /* 2 */
  border-style: solid;
  /* 2 */
  border-color: #e5e7eb;
  /* 2 */
}

::before,
::after {
  --tw-content: '';
}

/*
1. Use a consistent sensible line-height in all browsers.
2. Prevent adjustments of font size after orientation changes in iOS.
3. Use a more readable tab size.
4. Use the user's configured `sans` font-family by default.
*/

html {
  line-height: 1.5;
  /* 1 */
  -webkit-text-size-adjust: 100%;
  /* 2 */
  -moz-tab-size: 4;
  /* 3 */
  -o-tab-size: 4;
     tab-size: 4;
  /* 3 */
  font-family: ui-sans-serif, system-ui, -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, "Helvetica Neue", Arial, "Noto Sans", sans-serif, "Apple Color Emoji", "Segoe UI Emoji", "Segoe UI Symbol", "Noto Color Emoji";
  /* 4 */
}

/*
1. Remove the margin in all browsers.
2. Inherit line-height from `html` so users can set them as a class directly on the `html` element.
*/

body {
  margin: 0;
  /* 1 */
  line-height: inherit;
  /* 2 */
}

/*
1. Add the correct height in Firefox.
2. Correct the inheritance of border color in Firefox. (https://bugzilla.mozilla.org/show_bug.cgi?id=190655)
3. Ensure horizontal rules are visible by default.
*/

hr {
  height: 0;
  /* 1 */
  color: inherit;
  /* 2 */
  border-top-width: 1px;
  /* 3 */
}

/*
Add the correct text decoration in Chrome, Edge, and Safari.
*/

abbr:where([title]) {
  -webkit-text-decoration: underline dotted;
          text-decoration: underline dotted;
}

/*
Remove the default font size and weight for headings.
*/

h1,
h2,
h3,
h4,
h5,
h6 {
  font-size: inherit;
  font-weight: inherit;
}

/*
Reset links to optimize for opt-in styling instead of opt-out.
*/

a {
  color: inherit;
  text-decoration: inherit;
}

/*
Add the correct font weight in Edge and Safari.
*/

b,
strong {
  font-weight: bolder;
}

/*
1. Use the user's configured `mono` font family by default.
2. Correct the odd `em` font sizing in all browsers.
*/

code,
kbd,
samp,
pre {
  font-family: ui-monospace, SFMono-Regular, Menlo, Monaco, Consolas, "Liberation Mono", "Courier New", monospace;
  /* 1 */
  font-size: 1em;
  /* 2 */
}

/*
Add the correct font size in all browsers.
*/

small {
  font-size: 80%;
}

/*
Prevent `sub` and `sup` elements from affecting the line height in all browsers.
*/

sub,
sup {
  font-size: 75%;
  line-height: 0;
  position: relative;
  vertical-align: baseline;
}

sub {
  bottom: -0.25em;
}

sup {
  top: -0.5em;
}

/*
1. Remove text indentation from table contents in Chrome and Safari. (https://bugs.chromium.org/p/chromium/issues/detail?id=999088, https://bugs.webkit.org/show_bug.cgi?id=201297)
2. Correct table border color inheritance in all Chrome and Safari. (https://bugs.chromium.org/p/chromium/issues/detail?id=935729, https://bugs.webkit.org/show_bug.cgi?id=195016)
3. Remove gaps between table borders by default.
*/

table {
  text-indent: 0;
  /* 1 */
  border-color: inherit;
  /* 2 */
  border-collapse: collapse;
  /* 3 */
}

/*
1. Change the font styles in all browsers.
2. Remove the margin in Firefox and Safari.
3. Remove default padding in all browsers.
*/

button,
input,
optgroup,
select,
textarea {
  font-family: inherit;
  /* 1 */
  font-size: 100%;
  /* 1 */
  font-weight: inherit;
  /* 1 */
  line-height: inherit;
  /* 1 */
  color: inherit;
  /* 1 */
  margin: 0;
  /* 2 */
  padding: 0;
  /* 3 */
}

/*
Remove the inheritance of text transform in Edge and Firefox.
*/

button,
select {
  text-transform: none;
}

/*
1. Correct the inability to style clickable types in iOS and Safari.
2. Remove default button styles.
*/

button,
[type='button'],
[type='reset'],
[type='submit'] {
  -webkit-appearance: button;
  /* 1 */
  background-color: transparent;
  /* 2 */
  background-image: none;
  /* 2 */
}

/*
Use the modern Firefox focus style for all focusable elements.
*/

:-moz-focusring {
  outline: auto;
}

/*
Remove the additional `:invalid` styles in Firefox. (https://github.com/mozilla/gecko-dev/blob/2f9eacd9d3d995c937b4251a5557d95d494c9be1/layout/style/res/forms.css#L728-L737)
*/

:-moz-ui-invalid {
  box-shadow: none;
}

/*
Add the correct vertical alignment in Chrome and Firefox.
*/

progress {
  vertical-align: baseline;
}

/*
Correct the cursor style of increment and decrement buttons in Safari.
*/

::-webkit-inner-spin-button,
::-webkit-outer-spin-button {
  height: auto;
}

/*
1. Correct the odd appearance in Chrome and Safari.
2. Correct the outline style in Safari.
*/

[type='search'] {
  -webkit-appearance: textfield;
  /* 1 */
  outline-offset: -2px;
  /* 2 */
}

/*
Remove the inner padding in Chrome and Safari on macOS.
*/

::-webkit-search-decoration {
  -webkit-appearance: none;
}

/*
1. Correct the inability to style clickable types in iOS and Safari.
2. Change font properties to `inherit` in Safari.
*/

::-webkit-file-upload-button {
  -webkit-appearance: button;
  /* 1 */
  font: inherit;
  /* 2 */
}

/*
Add the correct display in Chrome and Safari.
*/

summary {
  display: list-item;
}

/*
Removes the default spacing and border for appropriate elements.
*/

blockquote,
dl,
dd,
h1,
h2,
h3,
h4,
h5,
h6,
hr,
figure,
p,
pre {
  margin: 0;
}

fieldset {
  margin: 0;
  padding: 0;
}

legend {
  padding: 0;
}

ol,
ul,
menu {
  list-style: none;
  margin: 0;
  padding: 0;
}

/*
Prevent resizing textareas horizontally by default.
*/

textarea {
  resize: vertical;
}

/*
1. Reset the default placeholder opacity in Firefox. (https://github.com/tailwindlabs/tailwindcss/issues/3300)
2. Set the default placeholder color to the user's configured gray 400 color.
*/

input::-moz-placeholder, textarea::-moz-placeholder {
  opacity: 1;
  /* 1 */
  color: #9ca3af;
  /* 2 */
}

input::placeholder,
textarea::placeholder {
  opacity: 1;
  /* 1 */
  color: #9ca3af;
  /* 2 */
}

/*
Set the default cursor for buttons.
*/

button,
[role="button"] {
  cursor: pointer;
}

/*
Make sure disabled buttons don't get the pointer cursor.
*/

:disabled {
  cursor: default;
}

/*
1. Make replaced elements `display: block` by default. (https://github.com/mozdevs/cssremedy/issues/14)
2. Add `vertical-align: middle` to align replaced elements more sensibly by default. (https://github.com/jensimmons/cssremedy/issues/14#issuecomment-634934210)
   This can trigger a poorly considered lint error in some tools but is included by design.
*/

img,
svg,
video,
canvas,
audio,
iframe,
embed,
object {
  display: block;
  /* 1 */
  vertical-align: middle;
  /* 2 */
}

/*
Constrain images and videos to the parent width and preserve their intrinsic aspect ratio. (https://github.com/mozdevs/cssremedy/issues/14)
*/

img,
video {
  max-width: 100%;
  height: auto;
}

/* Make elements with the HTML hidden attribute stay hidden by default */

[hidden] {
  display: none;
}

*, ::before, ::after {
  --tw-border-spacing-x: 0;
  --tw-border-spacing-y: 0;
  --tw-translate-x: 0;
  --tw-translate-y: 0;
  --tw-rotate: 0;
  --tw-skew-x: 0;
  --tw-skew-y: 0;
  --tw-scale-x: 1;
  --tw-scale-y: 1;
  --tw-pan-x:  ;
  --tw-pan-y:  ;
  --tw-pinch-zoom:  ;
  --tw-scroll-snap-strictness: proximity;
  --tw-ordinal:  ;
  --tw-slashed-zero:  ;
  --tw-numeric-figure:  ;
  --tw-numeric-spacing:  ;
  --tw-numeric-fraction:  ;
  --tw-ring-inset:  ;
  --tw-ring-offset-width: 0px;
  --tw-ring-offset-color: #fff;
  --tw-ring-color: rgb(59 130 246 / 0.5);
  --tw-ring-offset-shadow: 0 0 #0000;
  --tw-ring-shadow: 0 0 #0000;
  --tw-shadow: 0 0 #0000;
  --tw-shadow-colored: 0 0 #0000;
  --tw-blur:  ;
  --tw-brightness:  ;
  --tw-contrast:  ;
  --tw-grayscale:  ;
  --tw-hue-rotate:  ;
  --tw-invert:  ;
  --tw-saturate:  ;
  --tw-sepia:  ;
  --tw-drop-shadow:  ;
  --tw-backdrop-blur:  ;
  --tw-backdrop-brightness:  ;
  --tw-backdrop-contrast:  ;
  --tw-backdrop-grayscale:  ;
  --tw-backdrop-hue-rotate:  ;
  --tw-backdrop-invert:  ;
  --tw-backdrop-opacity:  ;
  --tw-backdrop-saturate:  ;
  --tw-backdrop-sepia:  ;
}

::-webkit-backdrop {
  --tw-border-spacing-x: 0;
  --tw-border-spacing-y: 0;
  --tw-translate-x: 0;
  --tw-translate-y: 0;
  --tw-rotate: 0;
  --tw-skew-x: 0;
  --tw-skew-y: 0;
  --tw-scale-x: 1;
  --tw-scale-y: 1;
  --tw-pan-x:  ;
  --tw-pan-y:  ;
  --tw-pinch-zoom:  ;
  --tw-scroll-snap-strictness: proximity;
  --tw-ordinal:  ;
  --tw-slashed-zero:  ;
  --tw-numeric-figure:  ;
  --tw-numeric-spacing:  ;
  --tw-numeric-fraction:  ;
  --tw-ring-inset:  ;
  --tw-ring-offset-width: 0px;
  --tw-ring-offset-color: #fff;
  --tw-ring-color: rgb(59 130 246 / 0.5);
  --tw-ring-offset-shadow: 0 0 #0000;
  --tw-ring-shadow: 0 0 #0000;
  --tw-shadow: 0 0 #0000;
  --tw-shadow-colored: 0 0 #0000;
  --tw-blur:  ;
  --tw-brightness:  ;
  --tw-contrast:  ;
  --tw-grayscale:  ;
  --tw-hue-rotate:  ;
  --tw-invert:  ;
  --tw-saturate:  ;
  --tw-sepia:  ;
  --tw-drop-shadow:  ;
  --tw-backdrop-blur:  ;
  --tw-backdrop-brightness:  ;
  --tw-backdrop-contrast:  ;
  --tw-backdrop-grayscale:  ;
  --tw-backdrop-hue-rotate:  ;
  --tw-backdrop-invert:  ;
  --tw-backdrop-opacity:  ;
  --tw-backdrop-saturate:  ;
  --tw-backdrop-sepia:  ;
}

::backdrop {
  --tw-border-spacing-x: 0;
  --tw-border-spacing-y: 0;
  --tw-translate-x: 0;
  --tw-translate-y: 0;
  --tw-rotate: 0;
  --tw-skew-x: 0;
  --tw-skew-y: 0;
  --tw-scale-x: 1;
  --tw-scale-y: 1;
  --tw-pan-x:  ;
  --tw-pan-y:  ;
  --tw-pinch-zoom:  ;
  --tw-scroll-snap-strictness: proximity;
  --tw-ordinal:  ;
  --tw-slashed-zero:  ;
  --tw-numeric-figure:  ;
  --tw-numeric-spacing:  ;
  --tw-numeric-fraction:  ;
  --tw-ring-inset:  ;
  --tw-ring-offset-width: 0px;
  --tw-ring-offset-color: #fff;
  --tw-ring-color: rgb(59 130 246 / 0.5);
  --tw-ring-offset-shadow: 0 0 #0000;
  --tw-ring-shadow: 0 0 #0000;
  --tw-shadow: 0 0 #0000;
  --tw-shadow-colored: 0 0 #0000;
  --tw-blur:  ;
  --tw-brightness:  ;
  --tw-contrast:  ;
  --tw-grayscale:  ;
  --tw-hue-rotate:  ;
  --tw-invert:  ;
  --tw-saturate:  ;
  --tw-sepia:  ;
  --tw-drop-shadow:  ;
  --tw-backdrop-blur:  ;
  --tw-backdrop-brightness:  ;
  --tw-backdrop-contrast:  ;
  --tw-backdrop-grayscale:  ;
  --tw-backdrop-hue-rotate:  ;
  --tw-backdrop-invert:  ;
  --tw-backdrop-opacity:  ;
  --tw-backdrop-saturate:  ;
  --tw-backdrop-sepia:  ;
}

.container {
  width: 100%;
}

@media (min-width: 640px) {
  .container {
    max-width: 640px;
  }
}

@media (min-width: 768px) {
  .container {
    max-width: 768px;
  }
}

@media (min-width: 1024px) {
  .container {
    max-width: 1024px;
  }
}

@media (min-width: 1280px) {
  .container {
    max-width: 1280px;
  }
}

@media (min-width: 1536px) {
  .container {
    max-width: 1536px;
  }
}

.fixed {
  position: fixed;
}

.sticky {
  position: sticky;
}

.top-0 {
  top: 0px;
}

.z-10 {
  z-index: 10;
}

.col-span-1 {
  grid-column: span 1 / span 1;
}

.col-span-3 {
  grid-column: span 3 / span 3;
}

.col-span-4 {
  grid-column: span 4 / span 4;
}

.col-span-5 {
  grid-column: span 5 / span 5;
}

.col-start-2 {
  grid-column-start: 2;
}

.row-span-1 {
  grid-row: span 1 / span 1;
}

.row-start-2 {
  grid-row-start: 2;
}

.row-start-4 {
  grid-row-start: 4;
}

.mx-auto {
  margin-left: auto;
  margin-right: auto;
}

.my-2 {
  margin-top: 0.5rem;
  margin-bottom: 0.5rem;
}

.my-3 {
  margin-top: 0.75rem;
  margin-bottom: 0.75rem;
}

.mx-10 {
  margin-left: 2.5rem;
  margin-right: 2.5rem;
}

.my-4 {
  margin-top: 1rem;
  margin-bottom: 1rem;
}

.my-12 {
  margin-top: 3rem;
  margin-bottom: 3rem;
}

.my-7 {
  margin-top: 1.75rem;
  margin-bottom: 1.75rem;
}

.my-6 {
  margin-top: 1.5rem;
  margin-bottom: 1.5rem;
}

.mt-0 {
  margin-top: 0px;
}

.mb-12 {
  margin-bottom: 3rem;
}

.mb-24 {
  margin-bottom: 6rem;
}

.mb-11 {
  margin-bottom: 2.75rem;
}

.mt-28 {
  margin-top: 7rem;
}

.inline {
  display: inline;
}

.flex {
  display: flex;
}

.grid {
  display: grid;
}

.hidden {
  display: none;
}

.h-32 {
  height: 8rem;
}

.h-auto {
  height: auto;
}

.h-screen {
  height: 100vh;
}

.h-5 {
  height: 1.25rem;
}

.max-h-screen {
  max-height: 100vh;
}

.max-h-40 {
  max-height: 10rem;
}

.min-h-screen {
  min-height: 100vh;
}

.w-full {
  width: 100%;
}

.w-36 {
  width: 9rem;
}

.w-10 {
  width: 2.5rem;
}

.w-32 {
  width: 8rem;
}

.w-40 {
  width: 10rem;
}

.w-56 {
  width: 14rem;
}

.w-44 {
  width: 11rem;
}

.w-5 {
  width: 1.25rem;
}

.w-24 {
  width: 6rem;
}

.w-28 {
  width: 7rem;
}

.w-16 {
  width: 4rem;
}

.max-w-7xl {
  max-width: 80rem;
}

.max-w-6xl {
  max-width: 72rem;
}

.max-w-5xl {
  max-width: 64rem;
}

.max-w-2xl {
  max-width: 42rem;
}

.flex-none {
  flex: none;
}

.grow {
  flex-grow: 1;
}

@-webkit-keyframes pulse {
  50% {
    opacity: .5;
  }
}

@keyframes pulse {
  50% {
    opacity: .5;
  }
}

.animate-pulse {
  -webkit-animation: pulse 2s cubic-bezier(0.4, 0, 0.6, 1) infinite;
          animation: pulse 2s cubic-bezier(0.4, 0, 0.6, 1) infinite;
}

.grid-flow-dense {
  grid-auto-flow: dense;
}

.grid-cols-1 {
  grid-template-columns: repeat(1, minmax(0, 1fr));
}

.grid-cols-4 {
  grid-template-columns: repeat(4, minmax(0, 1fr));
}

.grid-cols-3 {
  grid-template-columns: repeat(3, minmax(0, 1fr));
}

.grid-rows-5 {
  grid-template-rows: repeat(5, minmax(0, 1fr));
}

.content-evenly {
  align-content: space-evenly;
}

.items-center {
  align-items: center;
}

.justify-between {
  justify-content: space-between;
}

.justify-items-center {
  justify-items: center;
}

.gap-2 {
  gap: 0.5rem;
}

.gap-8 {
  gap: 2rem;
}

.gap-4 {
  gap: 1rem;
}

.gap-x-5 {
  -moz-column-gap: 1.25rem;
       column-gap: 1.25rem;
}

.space-x-2 > :not([hidden]) ~ :not([hidden]) {
  --tw-space-x-reverse: 0;
  margin-right: calc(0.5rem * var(--tw-space-x-reverse));
  margin-left: calc(0.5rem * calc(1 - var(--tw-space-x-reverse)));
}

.rounded-sm {
  border-radius: 0.125rem;
}

.rounded-xl {
  border-radius: 0.75rem;
}

.border-4 {
  border-width: 4px;
}

.border-b-2 {
  border-bottom-width: 2px;
}

.border-gray-400 {
  --tw-border-opacity: 1;
  border-color: rgb(156 163 175 / var(--tw-border-opacity));
}

.bg-white {
  --tw-bg-opacity: 1;
  background-color: rgb(255 255 255 / var(--tw-bg-opacity));
}

.bg-best-background {
  background-image: url('./public/images/fundo1.jpg');
}

.from-black {
  --tw-gradient-from: #000;
  --tw-gradient-to: rgb(0 0 0 / 0);
  --tw-gradient-stops: var(--tw-gradient-from), var(--tw-gradient-to);
}

.to-black {
  --tw-gradient-to: #000;
}

.object-cover {
  -o-object-fit: cover;
     object-fit: cover;
}

.p-2 {
  padding: 0.5rem;
}

.p-0 {
  padding: 0px;
}

.p-6 {
  padding: 1.5rem;
}

.py-3 {
  padding-top: 0.75rem;
  padding-bottom: 0.75rem;
}

.px-7 {
  padding-left: 1.75rem;
  padding-right: 1.75rem;
}

.py-16 {
  padding-top: 4rem;
  padding-bottom: 4rem;
}

.px-32 {
  padding-left: 8rem;
  padding-right: 8rem;
}

.px-3 {
  padding-left: 0.75rem;
  padding-right: 0.75rem;
}

.py-6 {
  padding-top: 1.5rem;
  padding-bottom: 1.5rem;
}

.py-2 {
  padding-top: 0.5rem;
  padding-bottom: 0.5rem;
}

.py-4 {
  padding-top: 1rem;
  padding-bottom: 1rem;
}

.px-20 {
  padding-left: 5rem;
  padding-right: 5rem;
}

.pt-40 {
  padding-top: 10rem;
}

.pr-24 {
  padding-right: 6rem;
}

.pl-16 {
  padding-left: 4rem;
}

.pt-12 {
  padding-top: 3rem;
}

.pb-16 {
  padding-bottom: 4rem;
}

.pt-4 {
  padding-top: 1rem;
}

.pb-10 {
  padding-bottom: 2.5rem;
}

.text-left {
  text-align: left;
}

.text-center {
  text-align: center;
}

.font-bnmachine {
  font-family: BN Machine, sans-serif;
}

.font-bnelements {
  font-family: BN Elements, sans-serif;
}

.text-2xl {
  font-size: 1.5rem;
  line-height: 2rem;
}

.text-3xl {
  font-size: 1.875rem;
  line-height: 2.25rem;
}

.text-xl {
  font-size: 1.25rem;
  line-height: 1.75rem;
}

.text-lg {
  font-size: 1.125rem;
  line-height: 1.75rem;
}

.font-bold {
  font-weight: 700;
}

.font-medium {
  font-weight: 500;
}

.font-semibold {
  font-weight: 600;
}

.uppercase {
  text-transform: uppercase;
}

.text-white {
  --tw-text-opacity: 1;
  color: rgb(255 255 255 / var(--tw-text-opacity));
}

.text-emerald-500 {
  --tw-text-opacity: 1;
  color: rgb(16 185 129 / var(--tw-text-opacity));
}

.text-lime-500 {
  --tw-text-opacity: 1;
  color: rgb(132 204 22 / var(--tw-text-opacity));
}

.text-green-500 {
  --tw-text-opacity: 1;
  color: rgb(34 197 94 / var(--tw-text-opacity));
}

.text-green-700 {
  --tw-text-opacity: 1;
  color: rgb(21 128 61 / var(--tw-text-opacity));
}

.text-amber-700 {
  --tw-text-opacity: 1;
  color: rgb(180 83 9 / var(--tw-text-opacity));
}

.text-gray-600 {
  --tw-text-opacity: 1;
  color: rgb(75 85 99 / var(--tw-text-opacity));
}

.text-gray-500 {
  --tw-text-opacity: 1;
  color: rgb(107 114 128 / var(--tw-text-opacity));
}

.brightness-150 {
  --tw-brightness: brightness(1.5);
  filter: var(--tw-blur) var(--tw-brightness) var(--tw-contrast) var(--tw-grayscale) var(--tw-hue-rotate) var(--tw-invert) var(--tw-saturate) var(--tw-sepia) var(--tw-drop-shadow);
}

.transition-transform {
  transition-property: transform;
  transition-timing-function: cubic-bezier(0.4, 0, 0.2, 1);
  transition-duration: 150ms;
}

.hover\:scale-105:hover {
  --tw-scale-x: 1.05;
  --tw-scale-y: 1.05;
  transform: translate(var(--tw-translate-x), var(--tw-translate-y)) rotate(var(--tw-rotate)) skewX(var(--tw-skew-x)) skewY(var(--tw-skew-y)) scaleX(var(--tw-scale-x)) scaleY(var(--tw-scale-y));
}

.hover\:brightness-200:hover {
  --tw-brightness: brightness(2);
  filter: var(--tw-blur) var(--tw-brightness) var(--tw-contrast) var(--tw-grayscale) var(--tw-hue-rotate) var(--tw-invert) var(--tw-saturate) var(--tw-sepia) var(--tw-drop-shadow);
}

@media (min-width: 640px) {
  .sm\:grid-cols-1 {
    grid-template-columns: repeat(1, minmax(0, 1fr));
  }
}

@media (min-width: 768px) {
  .md\:my-1 {
    margin-top: 0.25rem;
    margin-bottom: 0.25rem;
  }

  .md\:mb-0 {
    margin-bottom: 0px;
  }

  .md\:grid-cols-2 {
    grid-template-columns: repeat(2, minmax(0, 1fr));
  }

  .md\:gap-14 {
    gap: 3.5rem;
  }

  .md\:text-left {
    text-align: left;
  }

  .md\:text-4xl {
    font-size: 2.25rem;
    line-height: 2.5rem;
  }

  .md\:text-xl {
    font-size: 1.25rem;
    line-height: 1.75rem;
  }
}

@media (min-width: 1024px) {
  .lg\:my-7 {
    margin-top: 1.75rem;
    margin-bottom: 1.75rem;
  }

  .lg\:my-auto {
    margin-top: auto;
    margin-bottom: auto;
  }

  .lg\:mt-10 {
    margin-top: 2.5rem;
  }

  .lg\:mb-3 {
    margin-bottom: 0.75rem;
  }

  .lg\:mt-6 {
    margin-top: 1.5rem;
  }

  .lg\:mt-40 {
    margin-top: 10rem;
  }

  .lg\:block {
    display: block;
  }

  .lg\:flex {
    display: flex;
  }

  .lg\:hidden {
    display: none;
  }

  .lg\:grid-cols-1 {
    grid-template-columns: repeat(1, minmax(0, 1fr));
  }

  .lg\:grid-cols-2 {
    grid-template-columns: repeat(2, minmax(0, 1fr));
  }

  .lg\:grid-cols-10 {
    grid-template-columns: repeat(10, minmax(0, 1fr));
  }

  .lg\:grid-cols-4 {
    grid-template-columns: repeat(4, minmax(0, 1fr));
  }

  .lg\:flex-row-reverse {
    flex-direction: row-reverse;
  }

  .lg\:gap-20 {
    gap: 5rem;
  }

  .lg\:p-7 {
    padding: 1.75rem;
  }

  .lg\:p-14 {
    padding: 3.5rem;
  }

  .lg\:text-left {
    text-align: left;
  }
}
