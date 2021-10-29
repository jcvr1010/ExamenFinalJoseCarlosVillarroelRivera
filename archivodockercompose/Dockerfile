# contenedor ubuntu-exfin v.0.1
FROM ubuntu:18.04
ENV DEBIAN_FRONTEND noninteractive
ENV DEBCONF_NONINTERACTIVE_SEEN true
RUN apt-get update -y
RUN apt-get install apache2 -y
RUN apt-get install nginx -y
RUN apt-get install terminador -y
ENTRYPOINT echo "instalacion exitosa"