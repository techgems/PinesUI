# PinesUI

An ASP.NET Core component library built on [Pines UI](https://devdojo.com/pines), using AlpineJS, TailwindCSS, and [Static Components](https://github.com/nickkane999/TechGems.StaticComponents).

## Installation

```bash
dotnet add package TechGems.PinesUI --version 1.0.0
```

## Setup

### 1. Register Static Components

In your `Program.cs`:

```csharp
builder.Services.AddStaticComponents();
```

### 2. Add Tag Helpers

In your `_ViewImports.cshtml`:

```cshtml
@addTagHelper *, TechGems.PinesUI
@addTagHelper *, TechGems.StaticComponents
```

### 3. Include Styles and Scripts

In your layout file (`_Layout.cshtml`):

```html
<head>
    <!-- PinesUI stylesheet (TailwindCSS-based) -->
    <pines-css />
</head>
<body>
    <!-- Your content -->

    <!-- AlpineJS, GSAP, and Alpine Focus plugin -->
    <pines-scripts />
    <!-- Component-level scripts -->
    <render-static-scripts />
</body>
```

## Included Components

- **Alert** - Contextual feedback messages
- **Badge** - Status indicators and labels
- **Banner** - Full-width notification bars
- **Breadcrumbs** - Navigation hierarchy indicators
- **Button** - Action buttons in multiple styles
- **Card** - Content containers with images
- **Date Picker** - Calendar-based date selection
- **Dropdown Menu** - Toggleable action menus
- **Icon** - SVG icon set
- **Image Gallery** - Interactive image viewer with lightbox
- **Input** - Text input fields
- **Marquee** - Auto-scrolling content
- **Modal** - Dialog overlays
- **Quote** - Styled blockquotes with attribution
- **Radio Group** - Radio button selection groups
- **Rating** - Star/heart rating inputs
- **Select** - Searchable dropdown selection
- **Switch** - Toggle switches
- **Table** - Data tables
- **Tabs** - Tabbed content panels
- **Text Animation** - GSAP-powered text animations
- **Typing Effect** - Typewriter text animations

## Tech Stack

- [AlpineJS](https://alpinejs.dev/) - Lightweight JavaScript framework
- [TailwindCSS](https://tailwindcss.com/) - Utility-first CSS
- [GSAP](https://greensock.com/gsap/) - Animation library
- [TechGems.StaticComponents](https://github.com/nickkane999/TechGems.StaticComponents) - Server-side component model

## License

MIT
