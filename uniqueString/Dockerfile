# https://github.com/dotnet/dotnet-docker
# https://hub.docker.com/_/microsoft-dotnet-sdk
FROM mcr.microsoft.com/dotnet/sdk:6.0-bullseye-slim as builder

WORKDIR /app

#RUN apk add --no-cache \
#    make

RUN apt-get update \
    && apt-get install -y --no-install-recommends \
    make \
    && apt-get -y clean \
    && rm -rf /var/lib/apt/lists/*

COPY . ./
RUN make local-build

FROM amd64/debian:bullseye-slim

WORKDIR /app

COPY --from=builder /app/out/ ./

ENTRYPOINT ["/app/uniqueString"]
