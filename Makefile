APP_NAME = WordCountApp

.PHONY: build
build:
	dotnet build

.PHONY: run
run:
	dotnet run --project $(APP_NAME)

.PHONY: clean
clean:
	dotnet clean