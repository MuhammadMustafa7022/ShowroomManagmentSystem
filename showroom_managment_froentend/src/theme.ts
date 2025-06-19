// src/theme.ts
import { createTheme } from '@mui/material/styles';

const theme = createTheme({
  palette: {
    mode: 'light', // ya 'dark'
    primary: {
      main: '#1976d2', // blue
    },
    secondary: {
      main: '#ff4081', // pink
    },
    background: {
      default: '#f5f5f5',
    },
  },
  typography: {
    fontFamily: 'Roboto, Arial',
  },
});

export default theme;
