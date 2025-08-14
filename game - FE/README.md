# Rock Paper Scissors Lizard Spock Game

This is a web-based implementation of the classic "Rock Paper Scissors Lizard Spock" game, built with React and TypeScript. The frontend communicates with a .NET backend API for game logic.

## Setup Instructions

### 1. Prerequisites

- [Node.js](https://nodejs.org/) (v16 or newer recommended)
- [npm](https://www.npmjs.com/) (comes with Node.js)
- Access to the backend API (see your team for backend setup)

### 2. Install Dependencies

In the project directory, run:

```
npm install
```

### 3. Configure Environment Variables

Copy `.env.example` to `.env` and set the backend API URL:

```
cp .env.example .env
# On Windows, use: copy .env.example .env
```

Edit `.env` and set `REACT_APP_API_BASE_URL` to your backend URL, e.g.:

```
REACT_APP_API_BASE_URL=http://localhost:5000
```

### 4. Start the App

```
npm start
```

The app will run at [http://localhost:3000](http://localhost:3000) by default.

### 5. Running Tests

```
npm test
```

## Project Structure

- `src/pages/` — Main pages (e.g., Game)
- `src/components/` — Reusable UI components (OptionButton, SimpleModal, etc.)
- `src/services/` — API and HTTP logic
- `src/models/` — TypeScript interfaces and types
- `src/` — App entry point and global styles

## Notes

- The backend API must be running and accessible at the URL specified in `.env`.
- For development, CORS must be enabled on the backend.
- See `.env.example` for required environment variables.

---

# Getting Started with Create React App

## Available Scripts

In the project directory, you can run:

### `npm start`

Runs the app in the development mode.\
Open [http://localhost:3000](http://localhost:3000) to view it in your browser.

The page will reload when you make changes.\
You may also see any lint errors in the console.

### `npm test`

Launches the test runner in the interactive watch mode.\
See the section about [running tests](https://facebook.github.io/create-react-app/docs/running-tests) for more information.

### `npm run build`

Builds the app for production to the `build` folder.\
It correctly bundles React in production mode and optimizes the build for the best performance.

The build is minified and the filenames include the hashes.\
Your app is ready to be deployed!

See the section about [deployment](https://facebook.github.io/create-react-app/docs/deployment) for more information.

### `npm run eject`

**Note: this is a one-way operation. Once you `eject`, you can't go back!**

If you aren't satisfied with the build tool and configuration choices, you can `eject` at any time. This command will remove the single build dependency from your project.

Instead, it will copy all the configuration files and the transitive dependencies (webpack, Babel, ESLint, etc) right into your project so you have full control over them. All of the commands except `eject` will still work, but they will point to the copied scripts so you can tweak them. At this point you're on your own.

You don't have to ever use `eject`. The curated feature set is suitable for small and middle deployments, and you shouldn't feel obligated to use this feature. However we understand that this tool wouldn't be useful if you couldn't customize it when you are ready for it.

## Learn More

You can learn more in the [Create React App documentation](https://facebook.github.io/create-react-app/docs/getting-started).

To learn React, check out the [React documentation](https://reactjs.org/).

### Code Splitting

This section has moved here: [https://facebook.github.io/create-react-app/docs/code-splitting](https://facebook.github.io/create-react-app/docs/code-splitting)

### Analyzing the Bundle Size

This section has moved here: [https://facebook.github.io/create-react-app/docs/analyzing-the-bundle-size](https://facebook.github.io/create-react-app/docs/analyzing-the-bundle-size)

### Making a Progressive Web App

This section has moved here: [https://facebook.github.io/create-react-app/docs/making-a-progressive-web-app](https://facebook.github.io/create-react-app/docs/making-a-progressive-web-app)

### Advanced Configuration

This section has moved here: [https://facebook.github.io/create-react-app/docs/advanced-configuration](https://facebook.github.io/create-react-app/docs/advanced-configuration)

### Deployment

This section has moved here: [https://facebook.github.io/create-react-app/docs/deployment](https://facebook.github.io/create-react-app/docs/deployment)

### `npm run build` fails to minify

This section has moved here: [https://facebook.github.io/create-react-app/docs/troubleshooting#npm-run-build-fails-to-minify](https://facebook.github.io/create-react-app/docs/troubleshooting#npm-run-build-fails-to-minify)
