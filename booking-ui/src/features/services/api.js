import axios from "axios";
import { Redirect, useHistory as history } from "react-router";
import TokenService from "./token.service";

const instance = axios.create({
  baseURL: "https://localhost:44309/api",
  headers: {
    "Content-Type": "application/json",
  },
});

instance.interceptors.request.use(
  (config) => {
    const token = TokenService.getLocalAccessToken();
    if (token) {
      config.headers["Authorization"] = 'Bearer ' + token;
    }
    return config;
  },
  (error) => {
    return Promise.reject(error);
  }
);

instance.interceptors.response.use(
  (res) => {
    return res;
  },
  async (err) => {
    const originalConfig = err.config;
    
    if (originalConfig.url !== "/Authentication/login" && err.response) {
      if ((err.response.status === 401 || err.response.status === 404) && !originalConfig._retry) {
        originalConfig._retry = true;

        try {
          const rs = await instance.post("/Authentication/refresh", {
            refreshToken: TokenService.getLocalRefreshToken(),
          });

          const { accessToken } = rs.data;
          TokenService.updateLocalAccessToken(accessToken);

          return instance(originalConfig);
        } catch (_error) {
          return Promise.reject(_error);
        }
      }
      
    }
    if ( err.response.status === 500) {
      window.location.href = "/login"
    }

    return Promise.reject(err);
  }
);

export default instance;