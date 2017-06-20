FROM ubuntu:17.04
RUN echo "deb [arch=amd64] http://dl.google.com/linux/chrome/deb/ stable main" >> /etc/apt/sources.list.d/google.list
RUN apt-get update
RUN apt-get install -y wget
RUN wget -q -O - https://dl.google.com/linux/linux_signing_key.pub | apt-key add -
RUN apt-get update
RUN apt-get install -y google-chrome-stable
EXPOSE 9222
CMD google-chrome --headless --disable-gpu --remote-debugging-port=9222 --remote-debugging-address=0.0.0.0