FROM nginx
COPY /Nginx/entrypoint.sh /entrypoint.sh
COPY /Nginx/nginx.conf.template  /etc/nginx/nginx.conf.template
# nginx config 경로: /etc/nginx/nginx.conf
ENTRYPOINT [ "/entrypoint.sh" ]
CMD ["nginx", "-g", "daemon off;"]